﻿namespace TaskManagementApp.Application.Requests;

public record PagedRequest(int ActivePage);
public record PagedSearchRequest(int ActivePage, string Search);
