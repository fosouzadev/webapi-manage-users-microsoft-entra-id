﻿using FoSouzaDev.FinancialControl.Application.DataTransferObjects;
using FoSouzaDev.FinancialControl.Application.Factories.Interfaces;
using FoSouzaDev.FinancialControl.Application.Services.Interfaces;
using FoSouzaDev.FinancialControl.Domain.Entities;
using FoSouzaDev.FinancialControl.Domain.Repositories;
using FoSouzaDev.FinancialControl.Domain.ValueObjects;

namespace FoSouzaDev.FinancialControl.Application.Services;

internal sealed class BankAccountAppService
    (IBankAccountFactory factory, IBankAccountRepository repository)
    : AppService<BankAccount, BankAccountDto, UpdateBankAccountDto, AddBankAccountDto>(factory, repository), IBankAccountAppService
{
    protected override void UpdateEntity(BankAccount entity, UpdateBankAccountDto dto)
    {
        entity.Name = new Name(dto.Name);
        entity.Description = dto.Description;
        entity.IsActive = dto.IsActive;
    }
}