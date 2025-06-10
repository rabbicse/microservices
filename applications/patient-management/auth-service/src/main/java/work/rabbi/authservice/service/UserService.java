package work.rabbi.authservice.service;

import java.util.Optional;
import org.springframework.stereotype.Service;
import work.rabbi.authservice.model.User;
import work.rabbi.authservice.repository.UserRepository;

@Service
public class UserService {

    private final UserRepository userRepository;

    public UserService(UserRepository userRepository) {
        this.userRepository = userRepository;
    }

    public Optional<User> findByEmail(String email) {
        return userRepository.findByEmail(email);
    }
}
