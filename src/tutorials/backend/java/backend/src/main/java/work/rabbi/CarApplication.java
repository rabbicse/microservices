package work.rabbi;

import lombok.extern.slf4j.Slf4j;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;
import org.springframework.web.servlet.config.annotation.CorsRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurer;
import work.rabbi.domain.Car;
import work.rabbi.domain.Owner;
import work.rabbi.repositories.CarRepository;
import work.rabbi.repositories.OwnerRepository;

import java.util.Arrays;

@Slf4j
@SpringBootApplication
public class CarApplication implements CommandLineRunner {
    @Autowired
    private CarRepository repository;
    @Autowired
    private OwnerRepository ownerRepository;

    public static void main(String[] args) {
        SpringApplication.run(CarApplication.class, args);
    }

    @Override
    public void run(String... args) throws Exception {
        // Add owner objects and save these to db
        Owner owner1 = Owner.builder()
                .firstName("John")
                .lastName("Johnson")
                .build();
        Owner owner2 = Owner.builder()
                .firstName("Mary")
                .lastName("Robinson")
                .build();
        ownerRepository.saveAll(Arrays.asList(owner1, owner2));

        // Add car object and link to owners and save these to db
        Car car1 = Car.builder()
                .brand("Ford")
                .model("Mustang")
                .color("Red")
                .model("ADF-1121")
                .years(2021)
                .price(59000)
                .owner(owner1)
                .build();

        Car car2 = Car.builder()
                .brand("Nissan")
                .model("Leaf")
                .color("White")
                .model("SSJ-3002")
                .years(2019)
                .price(29000)
                .owner(owner2)
                .build();
        Car car3 = Car.builder()
                .brand("Toyota")
                .model("Prius")
                .color("Silver")
                .model("KKO-0212")
                .years(2020)
                .price(39000)
                .owner(owner1)
                .build();
        repository.saveAll(Arrays.asList(car1, car2, car3));

        for (Car car : repository.findAll()) {
            log.info(car.getBrand() + " " + car.getModel());
        }
    }

    @Bean
    public WebMvcConfigurer corsConfigurer() {
        return new WebMvcConfigurer() {
            @Override
            public void addCorsMappings(CorsRegistry registry) {
                registry.addMapping("/**").allowedOrigins("*");
            }
        };
    }

}
