package work.rabbi.api;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import work.rabbi.domain.Car;
import work.rabbi.repositories.CarRepository;

//@CrossOrigin(origins = "http://localhost:3000")
@RestController
@RequestMapping("/api/v1")
public class CarController {
    @Autowired
    private CarRepository repository;

    @RequestMapping("/cars")
    public Iterable<Car> getAllCars() {
        return repository.findAll();
    }

    @RequestMapping("/car")
    public Iterable<Car> getCars() {
        return repository.findAll();
    }
}
