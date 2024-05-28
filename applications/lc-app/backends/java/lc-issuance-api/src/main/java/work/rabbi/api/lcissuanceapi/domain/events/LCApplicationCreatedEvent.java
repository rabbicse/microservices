package work.rabbi.api.lcissuanceapi.domain.events;

import lombok.Data;
import work.rabbi.api.lcissuanceapi.domain.AdvisingBank;
import work.rabbi.api.lcissuanceapi.domain.LCApplicationId;

@Data
public class LCApplicationCreatedEvent {
    private final LCApplicationId id;
    private AdvisingBank advisingBank;

    public LCApplicationCreatedEvent(LCApplicationId id) {
        this.id = id;
    }

    public LCApplicationCreatedEvent(LCApplicationId id, AdvisingBank advisingBank) {
        this.id = id;
        this.advisingBank = advisingBank;
    }
}
