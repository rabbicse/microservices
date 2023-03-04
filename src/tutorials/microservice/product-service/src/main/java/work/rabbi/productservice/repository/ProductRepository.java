package work.rabbi.productservice.repository;

import org.springframework.data.mongodb.repository.MongoRepository;
import work.rabbi.productservice.model.Product;

public interface ProductRepository extends MongoRepository<Product, String> {
}
