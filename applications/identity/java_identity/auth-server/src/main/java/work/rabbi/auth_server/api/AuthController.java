package work.rabbi.auth_server.api;

import lombok.AllArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import work.rabbi.auth_server.core.AuthService;
import work.rabbi.auth_server.core.LoginResponse;
import work.rabbi.auth_server.core.LoginUserRequest;
import work.rabbi.auth_server.core.RegisterUserRequest;

@RestController
@RequestMapping("/auth")
@AllArgsConstructor
public class AuthController {
    private AuthService authService;

    @PostMapping("/signup")
    public ResponseEntity<String> register(@RequestBody RegisterUserApiRequest request) {
        RegisterUserRequest userRequest = RegisterUserRequest.builder()
                .email(request.email())
                .password(request.password())
                .fullName(request.fullName())
                .build();
        return ResponseEntity.ok(authService.register(userRequest));
    }

    @PostMapping("/login")
    public ResponseEntity<LoginApiResponse> login(@RequestBody LoginUserApiRequest request) {
        LoginResponse response = authService.login(from(request));
        LoginApiResponse apiResponse = from(response);
        return ResponseEntity.ok(apiResponse);
    }

    private static LoginApiResponse from(LoginResponse response) {
        return LoginApiResponse.builder()
                .token(response.token())
                .expiresIn(response.expiresIn())
                .build();
    }

    private static LoginUserRequest from(LoginUserApiRequest request) {
        return LoginUserRequest.builder()
                .username(request.username())
                .password(request.password())
                .build();
    }
}
