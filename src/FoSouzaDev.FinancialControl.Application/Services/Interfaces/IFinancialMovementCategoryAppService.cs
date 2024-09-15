﻿using FoSouzaDev.FinancialControl.Application.DataTransferObjects;
using Microsoft.AspNetCore.JsonPatch;

namespace FoSouzaDev.FinancialControl.Application.Services.Interfaces;

public interface IFinancialMovementCategoryAppService
{
    Task<Guid> AddAsync(FinancialMovementCategoryDto dto);
    Task<FinancialMovementCategoryDto> GetByIdAsync(Guid id);
    Task UpdateAsync(Guid id, JsonPatchDocument<UpdateFinancialMovementCategoryDto> pathDocument);
    Task RemoveAsync(Guid id);
}