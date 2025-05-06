package work.rabbi.auth_server.core;

import org.springframework.stereotype.Service;

@Service
public interface AuthService {
    String register(RegisterUserRequest request);
}
