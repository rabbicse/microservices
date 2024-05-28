package work.rabbi.orderservice.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import work.rabbi.orderservice.model.Order;

public interface OrderRepository extends JpaRepository<Order, Long> {
}
