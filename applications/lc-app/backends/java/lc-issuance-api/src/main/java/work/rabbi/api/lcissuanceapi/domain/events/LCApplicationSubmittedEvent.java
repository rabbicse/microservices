package work.rabbi.api.lcissuanceapi.domain.events;

import work.rabbi.api.lcissuanceapi.domain.LCApplicationId;

public class LCApplicationSubmittedEvent {
    private final LCApplicationId applicationId;

    public LCApplicationSubmittedEvent(LCApplicationId applicationId) {
        this.applicationId = applicationId;
    }
}
