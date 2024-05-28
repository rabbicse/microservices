package work.rabbi.api.lcissuanceapi.domain.commands;


import lombok.Data;
import work.rabbi.api.lcissuanceapi.domain.LCApplicationId;
import work.rabbi.api.lcissuanceapi.domain.Country;

@Data
public class CreateLCApplicationCommand {
    private LCApplicationId id;
    private Country beneficiaryCountry;

    public CreateLCApplicationCommand() {
        this.id = LCApplicationId.randomId();
    }

    public CreateLCApplicationCommand(LCApplicationId id, Country beneficiaryCountry) {
        this.id = id;
        this.beneficiaryCountry = beneficiaryCountry;
    }
}
