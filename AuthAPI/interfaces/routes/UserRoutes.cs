namespace AuthAPI.interfaces.routes
{
    public class UserRoutes
    {
        public static void Route(IEndpointRouteBuilder app)
        {
            app.MapGet("/api/v1/users", () => "Get all users");
            app.MapGet("/api/v1/users/{id}", () => "Get user by id {id}");
            app.MapPost("/api/v1/users", () => "Create user");
            app.MapPut("/api/v1/users/{id}", () => "Update user");
            app.MapDelete("/api/v1/users/{id}", () => "Delete user");
        }
    }
}
