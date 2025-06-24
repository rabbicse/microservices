package work.rabbi.auth_server.core;

public interface UserPersister {
    String register(RegisterUserRequest request);
}

