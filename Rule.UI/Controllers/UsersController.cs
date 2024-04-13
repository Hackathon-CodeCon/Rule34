using Microsoft.AspNetCore.Mvc;
using Rule.BL.Models;
using Rule.BL.Services;
using Rule.Common.Extensions;

namespace Rule.UI.Controllers
{
    public class UsersController : Controller
    {
        private readonly UsersService _service;

        public UsersController(UsersService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync(UsersDTO newUsers)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                foreach (var error in errors)
                {
                    ModelState.AddModelError("", error);
                }
                return View(newUsers);
            }

            try
            {
                var createdUsers = await _service.CreateAsync(newUsers);
                TempData["SuccessMessage"] = "Фонд успішно створено!";
                return RedirectToAction("Index");
            }
            catch (DuplicateItemException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            catch (ServerErrorException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }

            return View(newUsers);
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<UsersDTO>>> GetAllAsync()
        {
            try
            {
                var getAllUsers = await _service.GetAllAsync();
                return View(getAllUsers);
            }
            catch (ServerErrorException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult<UsersDTO>> GetByIdAsync(int id)
        {
            try
            {
                var getByUsers = await _service.GetByIdAsync(id);
                return View(getByUsers);
            }
            catch (InvalidIdException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            catch (ServerErrorException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }

            return RedirectToAction("Index");
        }

        #region Http Get & Post method Update
        [HttpGet]
        public async Task<IActionResult> UpdateAsync(int id)
        {
            try
            {
                var updateAsUsers = await _service.GetByIdAsync(id);
                if (updateAsUsers == null || updateAsUsers.Id != id)
                {
                    TempData["ErrorMessage"] = "Фонд з таким ідентифікатором не знайдено";
                    return RedirectToAction("Index");
                }
                return View(updateAsUsers);
            }
            catch (InvalidIdException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            catch (ServerErrorException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult<UsersDTO>> UpdateAsync(UsersDTO updateUs)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                foreach (var error in errors)
                {
                    ModelState.AddModelError("", error);
                }
                return RedirectToAction("Index");
            }

            try
            {
                await _service.UpdateAsync(updateUs);
                TempData["SuccessMessage"] = "Фонд успішно оновлено!";
            }
            catch (InvalidIdException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            catch (DuplicateItemException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            catch (ServerErrorException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Http Get & Post method Delete
        [HttpGet]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                var deleteUs = await _service.GetByIdAsync(id);
                return View(deleteUs);
            }
            catch (InvalidIdException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            catch (ServerErrorException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmedAsync(int id)
        {
            try
            {
                await _service.DeleteAsync(id);
                TempData["SuccessMessage"] = "Фонд успішно видалено!";
            }
            catch (InvalidIdException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            catch (ServerErrorException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }

            return RedirectToAction("Index");
        }
        #endregion
    }
}
