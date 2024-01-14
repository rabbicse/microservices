package work.rabbi.api.lcissuanceapi.domain.commands;

import lombok.Data;
import org.axonframework.modelling.command.TargetAggregateIdentifier;
import work.rabbi.api.lcissuanceapi.domain.LCApplicationId;

@Data
public class SubmitLCApplicationCommand {
    @TargetAggregateIdentifier // <1>
    private final LCApplicationId applicationId;

    public SubmitLCApplicationCommand(LCApplicationId applicationId) {
        this.applicationId = applicationId;
    }
}
