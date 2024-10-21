using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StateMaster.Data;
using StateMaster.Models;
using StateMaster.Models.Entites;


namespace StateMaster.Controllers
{
    public class StateController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public StateController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStateViewModel viewModel)
        {
            var state = new State
            {
                StateNameEnglish = viewModel.StateNameEnglish,
                StateNameHindi = viewModel.StateNameHindi,
                StateNameCode = viewModel.StateNameCode,
                Status = viewModel.Status,
            };

            await dbContext.States.AddAsync(state);
            await dbContext.SaveChangesAsync();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var states = await dbContext.States.ToListAsync();

            return View(states);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid Id)
        {
            var state = await dbContext.States.FindAsync(Id);
            return View(state);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(State viewModel)
        {
            var state = await dbContext.States.FindAsync(viewModel.Id);
            if (state is not null)
            {
                state.StateNameEnglish = viewModel.StateNameEnglish;
                state.StateNameHindi = viewModel.StateNameHindi;
                state.StateNameCode = viewModel.StateNameCode;
                state.Status = viewModel.Status;

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "State");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(State viewModel)
        {

            var state = await dbContext.States.AsNoTracking()
               .FirstOrDefaultAsync(x => x.Id == viewModel.Id);
            if (state is not null)
            {
                dbContext.States.Remove(viewModel);
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "State");
        }
    }
}