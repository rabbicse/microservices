package work.rabbi.auth_server.api;

import lombok.AllArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import work.rabbi.auth_server.core.AuthService;
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
}
