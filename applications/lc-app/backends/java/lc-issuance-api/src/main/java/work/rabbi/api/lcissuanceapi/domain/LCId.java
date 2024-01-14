package work.rabbi.api.lcissuanceapi.domain;

import java.util.UUID;

public class LCId extends BaseId {
    protected LCId(UUID id) {
        super(id);
    }

    public static LCId from(UUID id) {
        return new LCId(id);
    }

}
