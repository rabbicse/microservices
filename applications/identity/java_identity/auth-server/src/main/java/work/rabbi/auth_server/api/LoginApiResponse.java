package work.rabbi.auth_server.api;

import lombok.Builder;

@Builder
public record LoginApiResponse(String token, long expiresIn) {
}
