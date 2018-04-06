﻿using System.Linq;
using System.Security.Claims;
using Freescape.Web.Data;
using Freescape.Web.Data.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace Freescape.Web.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly DataContext _db;
        
        public AuthorizationController(DataContext db)
        {
            _db = db;
        }

        public IActionResult Login()
        {
            return Challenge(new AuthenticationProperties {RedirectUri = "/Authorization/Authorized"}, "Discord");
        }

        public IActionResult Logout()
        {
            return SignOut(new AuthenticationProperties { RedirectUri = "/" },
                CookieAuthenticationDefaults.AuthenticationScheme);
        }

        public IActionResult Authorized()
        {
            var claims = User.Claims.ToList();

            Users user = new Users
            {
                Username = claims.Where(x => x.Type == ClaimTypes.Name).Select(x => x.Value).Single(),
                DiscordUserId = claims.Where(x => x.Type == ClaimTypes.NameIdentifier).Select(x => x.Value).Single(),
                Email = claims.Where(x => x.Type == ClaimTypes.Email).Select(x => x.Value).Single(),
                Discriminator = claims.Where(x => x.Type == "Discriminator").Select(x => x.Value).Single(),
                AvatarHash = claims.Where(x => x.Type == "Avatar").Select(x => x.Value).Single()
            };

            Users existingUser = _db.Users.SingleOrDefault(x => x.DiscordUserId == user.DiscordUserId);
            if (existingUser == null)
            {
                _db.Users.Add(user);
            }
            else
            {
                existingUser.Username = user.Username;
                existingUser.Discriminator = user.Discriminator;
                existingUser.Email = user.Email;
                existingUser.DiscordUserId = user.DiscordUserId;
                existingUser.AvatarHash = user.AvatarHash;

                user.UserId = existingUser.UserId;
            }

            _db.SaveChanges();

            return Redirect("/");
        }
    }
}