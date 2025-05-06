package work.rabbi.auth_server.api;

public record RegisterUserApiRequest(String email,
                                     String password,
                                     String fullName) {
}
