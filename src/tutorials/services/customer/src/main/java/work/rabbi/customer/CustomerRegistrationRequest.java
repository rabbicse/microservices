package work.rabbi.customer;

public record CustomerRegistrationRequest(
        String firstName,
        String lastName,
        String email) {
}
