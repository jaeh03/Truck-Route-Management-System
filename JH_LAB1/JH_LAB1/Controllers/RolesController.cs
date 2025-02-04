using JH_LAB1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JH_LAB1.Controllers
{
    public class RolesController : Controller
    {
        //private readonly LoadDbContext _context;
        private RoleManager<IdentityRole> roleManager;


        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        // GET: Roles
        public IActionResult Index()
        {
            var role = roleManager.Roles.ToList();
            var roles = roleManager.Roles.Select(x => new JH_LAB1.Models.Role
            {
                Id = Guid.Parse(x.Id),
                Name = x.Name
            });
            return View(roles);
        }

        // GET: Roles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Role role)
        {
            if (ModelState.IsValid)
            {
                // Create new IdentityRole based on Role model
                var identityRole = new IdentityRole
                {
                    Name = role.Name
                };

                // Create the role using RoleManager
                var result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    // Redirect to Index action after successful creation
                    return RedirectToAction(nameof(Index));
                }

                // Add model errors if role creation fails
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If ModelState is not valid, return to Create view with model errors
            return View(role);
        }

        // GET: Roles/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            var roleModel = new JH_LAB1.Models.Role
            {
                Id = Guid.Parse(role.Id),
                Name = role.Name
            };

            return View(roleModel);
        }

        // POST: Roles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Role role)
        {
            if (id != role.Id.ToString())
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingRole = await roleManager.FindByIdAsync(id);
                if (existingRole == null)
                {
                    return NotFound();
                }

                existingRole.Name = role.Name;
                var result = await roleManager.UpdateAsync(existingRole);

                if (result.Succeeded)
                {
                    // Redirect to Index action after successful update
                    return RedirectToAction(nameof(Index));
                }

                // Add model errors if role update fails
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If ModelState is not valid, return to Edit view with model errors
            return View(role);
        }

        // GET: Roles/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            var roleModel = new JH_LAB1.Models.Role
            {
                Id = Guid.Parse(role.Id),
                Name = role.Name
            };

            return View(roleModel);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            var result = await roleManager.DeleteAsync(role);

            if (result.Succeeded)
            {
                // Redirect to Index action after successful deletion
                return RedirectToAction(nameof(Index));
            }

            // Add model errors if role deletion fails
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            // If ModelState is not valid, return to Delete view with model errors
            return View(id);
        }
    }
}
