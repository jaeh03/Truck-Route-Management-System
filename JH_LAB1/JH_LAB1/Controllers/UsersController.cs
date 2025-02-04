using JH_LAB1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JH_LAB1.Controllers
{
    public class UsersController : Controller
    {
        /*
        //private readonly LoadDbContext _context;
        private UserManager<AppUser> userManager;
        private IPasswordHasher<AppUser> passwordHasher;


        public UsersController(UserManager<AppUser> usrMgr, IPasswordHasher<AppUser> passwordHasher)
        {
            userManager = usrMgr;
            this.passwordHasher = passwordHasher;

        }

        private async Task<bool> UserExists(Guid id)
        {
            var user = await userManager.Users.FirstOrDefaultAsync(m => m.Id == id.ToString());
            return user != null;
        }

        // GET: Users
        public IActionResult Index()
        {
            var users = userManager.Users.Select(u => new JH_LAB1.Models.User
            {
                // Map AppUser properties to User properties
                Id = Guid.Parse(u.Id), // Parse string to Guid
                Name = u.UserName,
                Email = u.Email,
                Password = u.PasswordHash,
                RoleId = u.RoleId ?? "No role"
                // Add other properties as needed
            }).OrderBy(x => x.RoleId);

            return View(users);

        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    UserName = user.Name,
                    Email = user.Email,
                    RoleId = user.RoleId
                };

                IdentityResult result = await userManager.CreateAsync(appUser, user.Password);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                {
                    foreach (IdentityError error in result.Errors) ModelState.AddModelError("", error.Description);
                }
            }
            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await userManager.FindByIdAsync(id.Value.ToString());
            if (user == null)
            {
                return NotFound();
            }
            var userModel = new User
            {
                Id = Guid.Parse(user.Id),
                Name = user.UserName,
                Email = user.Email,
                Password = user.PasswordHash,
                RoleId = user.RoleId ?? "No role"
            };
            return View(userModel);
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Email,Password,RoleId")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var appUser = await userManager.FindByIdAsync(user.Id.ToString());
                    appUser.UserName = user.Name;
                    appUser.Email = user.Email;
                    appUser.RoleId = user.RoleId;

                    // Update password only if it is not empty
                    if (!string.IsNullOrEmpty(user.Password))
                    {
                        var newPasswordHash = userManager.PasswordHasher.HashPassword(appUser, user.Password);
                        appUser.PasswordHash = newPasswordHash;
                    }

                    var result = await userManager.UpdateAsync(appUser);
                    if (result.Succeeded)
                        return RedirectToAction(nameof(Index));
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                            ModelState.AddModelError("", error.Description);
                    }
                }
                catch (FormatException)
                {
                    if (!await UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            // Add the following return statement at the end of the method
            return View(user);
        }



        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await userManager.Users.FirstOrDefaultAsync(m => m.Id == id.Value.ToString());
            var userModel = new User
            {
                Id = Guid.Parse(user.Id),
                Name = user.UserName,
                Email = user.Email,
                Password = user.PasswordHash,
                RoleId = user.RoleId ?? "No role"
            };

            if (user == null)
            {
                return NotFound();
            }

            return View(userModel);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User not found.");
            }

            return View();
        }
        */

    }
        
    
        
}
