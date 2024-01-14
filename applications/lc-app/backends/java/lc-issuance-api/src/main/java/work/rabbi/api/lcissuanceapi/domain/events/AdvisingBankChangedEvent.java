package work.rabbi.api.lcissuanceapi.domain.events;


import lombok.Data;
import work.rabbi.api.lcissuanceapi.domain.AdvisingBank;
import work.rabbi.api.lcissuanceapi.domain.LCApplicationId;

@Data
public class AdvisingBankChangedEvent {
    private final LCApplicationId applicationId;
    private final AdvisingBank advisingBank;
}
