using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace FilmesAPI.Authorization
{
    public class IdadeMinimaHandler : AuthorizationHandler<IdadeMinimaRequirement>
    {

        private readonly IHttpContextAccessor _httpContextAccessor;

        public IdadeMinimaHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IdadeMinimaRequirement requirement)
        {

            var httpContext = _httpContextAccessor.HttpContext;

            // Suponha que o parâmetro seja passado na rota. Exemplo: /api/controller/action/{roleId}
            var routeData = httpContext.GetRouteData();

            if (!context.User.HasClaim(c => c.Type == ClaimTypes.DateOfBirth))
                    return Task.CompletedTask;

            DateTime dataNascimento = Convert.ToDateTime(context.User.FindFirst(c =>
                c.Type == ClaimTypes.DateOfBirth
            )!.Value);

            int idadeObtida = DateTime.Today.Year - dataNascimento.Year;

            if (dataNascimento > DateTime.Today.AddYears(-idadeObtida))
                idadeObtida--;

            if (idadeObtida >= requirement.IdadeMinima) context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
