package work.rabbi.api.lcissuanceapi.domain.commands;

import lombok.Data;
import org.axonframework.modelling.command.TargetAggregateIdentifier;
import work.rabbi.api.lcissuanceapi.domain.AdvisingBank;
import work.rabbi.api.lcissuanceapi.domain.LCApplicationId;

@Data
public class ChangeAdvisingBankCommand {

    @TargetAggregateIdentifier
    private final LCApplicationId applicationId;
    private final AdvisingBank advisingBank;
}
