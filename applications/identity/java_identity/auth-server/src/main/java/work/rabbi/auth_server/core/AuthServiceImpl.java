package work.rabbi.auth_server.core;

import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;

@Service
@AllArgsConstructor
public class AuthServiceImpl implements AuthService {
    private UserPersister userPersister;

    @Override
    public String register(RegisterUserRequest request) {
        return "";
    }
}
