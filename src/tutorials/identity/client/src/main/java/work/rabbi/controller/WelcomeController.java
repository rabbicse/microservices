package work.rabbi.controller;

import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;
import work.rabbi.config.WelcomeClient;

@RestController
@RequiredArgsConstructor
public class WelcomeController {
    private final WelcomeClient welcomeClient;
    @GetMapping("/")
    public String welcome() {
        String welcome = welcomeClient.getWelcome();
        return "<h1>" +  welcome + "</h1>";
    }
}
