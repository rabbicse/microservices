package work.rabbi.auth_server.core;

import lombok.Builder;

@Builder
public record LoginUserRequest(String username, String password) {
}
