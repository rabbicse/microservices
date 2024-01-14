package work.rabbi.api.lcissuanceapi.domain;

public class AlreadySubmittedException extends DomainException {
    public AlreadySubmittedException(String message) {
        super(message);
    }
}
