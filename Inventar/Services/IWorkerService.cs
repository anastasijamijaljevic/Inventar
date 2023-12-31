﻿using Inventar.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inventar.Services
{
    public interface IWorkerService
    {
        Task<IActionResult> Get();
        Task<IActionResult> GetById(Guid id);
        Task<IActionResult> Create(Worker worker);
        Task<IActionResult> Update(Worker worker);
        Task<Guid> Delete(Guid id);
    }
}
