namespace TaskManagementApp.Application.Handlers;

public class RegisterRequestHandler : IRequestHandler<RegisterRequest, Result<NoData>>
{
    private readonly IUserRepository _userRepository;

    public RegisterRequestHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<NoData>> Handle(RegisterRequest request, CancellationToken cancellationToken)
    {
        var validator = new RegisterRequestValidator();
        var validateResult = await validator.ValidateAsync(request);
        if (validateResult.IsValid)
        {
            var result = await _userRepository.CreateUserAsync(request.ToAppUser());
            if (result > 0)
                return new Result<NoData>(new NoData(), true, null, null);
            else
                return new Result<NoData>(new NoData(), false, "User could not be created", null);
        }
        else
        {
            var errorList = validateResult.Errors.ToMap();

            return new Result<NoData>(new NoData(), false, "ValidationError", errorList);
        }
    }
}
