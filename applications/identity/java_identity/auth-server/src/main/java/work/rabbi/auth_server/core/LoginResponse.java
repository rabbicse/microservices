package work.rabbi.auth_server.core;

import lombok.Builder;

@Builder
public record LoginResponse(String token, long expiresIn) {
}
