package work.rabbi.config;

import org.springframework.context.annotation.Bean;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.web.SecurityFilterChain;

@EnableWebSecurity
public class InventoryServiceConfig {

    @Bean
    SecurityFilterChain securityFilterChain(HttpSecurity http) throws Exception {
        http.securityMatcher("/**")
                .authorizeRequests()
                .anyRequest()
                .access("hasAuthority('SCOPE_articles.read')")
                .and()
                .oauth2ResourceServer()
                .jwt();
        return http.build();
    }
}
