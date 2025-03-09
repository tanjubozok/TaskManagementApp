﻿namespace TaskManagementApp.Application.Interfaces;

public interface IAppTaskRepository
{
    Task<PagedData<AppTask>> GetAllAsync(int activePage, int pageSize = 10);
}
