package work.rabbi.patientservice.mapper;

import work.rabbi.patientservice.dto.PatientRequestDTO;
import work.rabbi.patientservice.dto.PatientResponseDTO;
import work.rabbi.patientservice.model.Patient;

import java.time.LocalDate;

public class PatientMapper {
    public static PatientResponseDTO toDTO(Patient patient) {
        return PatientResponseDTO.builder()
                .id(patient.getId())
                .name(patient.getName())
                .address(patient.getAddress())
                .email(patient.getEmail())
                .dateOfBirth(patient.getDateOfBirth().toString())
                .build();
    }

    public static Patient toModel(PatientRequestDTO patientRequestDTO) {
        Patient patient = Patient.builder()
                .name(patientRequestDTO.getName())
                .address(patientRequestDTO.getAddress())
                .email(patientRequestDTO.getEmail())
                .dateOfBirth(LocalDate.parse(patientRequestDTO.getDateOfBirth()))
                .registeredDate(LocalDate.parse(patientRequestDTO.getRegisteredDate()))
                .build();
        patient.setRegisteredDate(LocalDate.parse(patientRequestDTO.getRegisteredDate()));
        return patient;
    }
}
