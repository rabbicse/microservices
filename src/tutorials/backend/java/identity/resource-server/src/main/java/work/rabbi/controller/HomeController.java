package work.rabbi.controller;

import org.springframework.security.core.Authentication;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import java.time.LocalDateTime;

@RestController
public class HomeController {
    @GetMapping("/")
    public String home(Authentication authentication) {
        LocalDateTime time = LocalDateTime.now();
        return "Welcome Home! - " + time + " - " + authentication.getName();
    }
}
