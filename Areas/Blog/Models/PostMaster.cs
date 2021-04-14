using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheatreCMS3.Models;

namespace TheatreCMS3.Areas.Blog.Models
{
    public class PostMaster : ApplicationUser
    {
        public int PublishedBlogPosts { get; set; }
        public int RejectedBlogPosts { get; set; }
        public int PendingBlogPosts { get; set; }

        public static void Seed(UserManager<PostMaster> userManger)
        {
            if (userManger.FindByNameAsync("user1").Result == null)
            {
                PostMaster user = new PostMaster();
                user.UserName = "user1";
                user.Email = "user1@localhost";
                user.PublishedBlogPosts = 0;
                user.RejectedBlogPosts = 0;
                user.PendingBlogPosts = 0;

                IdentityResult result = userManger.CreateAsync(user, "password").Result;

                if (result.Succeeded)
                {
                    userManger.AddToRoleAsync(user.Id, "PostMaster").Wait(); //I don't think this set the role correctly
                }
            }
        }
    }
}

//these are probably done wrong

//need to figure out what goes in here, and where to call this

//put in startup to test code, put under ConfigureAuth(app);
//AccountController POST: /Account/Register method for example
//like adding another model to the table for DbContext Db.tablename.add, like create method of BlogPost
//Users to AspNetUsers
//seeding custom user using identity good serch terms

//blogpost model has seed method
//call that method in startup

//create instance of role and user manager
//acount controller account/register is the prime example that needs to be emulated?
//using managers that are already created