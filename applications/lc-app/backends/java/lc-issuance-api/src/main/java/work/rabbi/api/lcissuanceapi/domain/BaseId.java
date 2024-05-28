package work.rabbi.api.lcissuanceapi.domain;

import jakarta.validation.constraints.NotNull;
import lombok.Data;
import java.io.Serializable;
import java.util.UUID;


@Data
public class BaseId implements Serializable {
    @NotNull
    private final UUID id;

    protected BaseId(UUID id) {
        this.id = id;
    }
}
