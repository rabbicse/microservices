package work.rabbi.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import work.rabbi.entity.User;

import java.util.Optional;

public interface UserRepository extends JpaRepository<User, Integer> {
    Optional<User> findByUsername(String username);
}
