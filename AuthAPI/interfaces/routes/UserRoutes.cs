namespace AuthAPI.interfaces.routes
{
    public class UserRoutes
    {
        public static void Route(IEndpointRouteBuilder app)
        {
            app.MapControllerRoute(
                    "Users",
                    "api/v1/users",
                    new { controller = "Users", action = "Get" }
            );
        }
    }
}
