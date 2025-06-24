package work.rabbi.auth_server.infra;

import lombok.AllArgsConstructor;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;
import work.rabbi.auth_server.core.RegisterUserRequest;
import work.rabbi.auth_server.core.UserPersister;

@Service
@AllArgsConstructor
public class UserPostgresPersister implements UserPersister {
    private UserRepository userRepository;
    private PasswordEncoder passwordEncoder;

    @Override
    public String register(RegisterUserRequest request) {
        UserEntity user = UserEntity.builder()
                .email(request.email())
                .fullName(request.fullName())
                .password(passwordEncoder.encode(request.password()))
                .build();
        return userRepository.save(user).getId().toString();
    }
}
