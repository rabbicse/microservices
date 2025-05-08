package work.rabbi.auth_server.core;

import lombok.AllArgsConstructor;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.Authentication;
import org.springframework.stereotype.Service;
import work.rabbi.auth_server.infra.UserEntity;
import work.rabbi.auth_server.infra.UserRepository;

import java.util.Optional;

@Service
@AllArgsConstructor
public class AuthServiceImpl implements AuthService {
    private UserPersister userPersister;
    private AuthenticationManager authenticationManager;
    private UserRepository userRepository;
    private JwtService jwtService;

    @Override
    public String register(RegisterUserRequest request) {
        return userPersister.register(request);
    }

    @Override
    public LoginResponse login(LoginUserRequest request) {
        Authentication authentication = new UsernamePasswordAuthenticationToken(request.username(), request.password());
        authenticationManager.authenticate(authentication);
        Optional<UserEntity> user = userRepository.findByEmail(request.username());
        if (user.isPresent()) {
            String token = jwtService.generateToken(user.get());
            return LoginResponse.builder().token(token).expiresIn(jwtService.getJwtExpirationInMilliseconds()).build();
        }
        return LoginResponse.builder().build();
    }
}
