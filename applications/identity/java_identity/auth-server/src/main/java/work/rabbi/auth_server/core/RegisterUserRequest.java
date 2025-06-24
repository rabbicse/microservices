package work.rabbi.auth_server.core;

import lombok.Builder;

@Builder
public record RegisterUserRequest(
        String email,
        String password,
        String fullName) {
}
