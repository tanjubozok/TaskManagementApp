namespace TaskManagementApp.Application.Requests;

public record PagedRequest(int acitvePage);
public record PagedSearchRequest(int activePage, string search);
