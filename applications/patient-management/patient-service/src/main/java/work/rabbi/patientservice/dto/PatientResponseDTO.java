package work.rabbi.patientservice.dto;

import lombok.*;

import java.util.UUID;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Builder
public class PatientResponseDTO {
    private UUID id;
    private String name;
    private String email;
    private String address;
    private String dateOfBirth;
}
