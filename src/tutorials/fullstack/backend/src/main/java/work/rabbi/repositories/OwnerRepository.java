package work.rabbi.repositories;

import org.springframework.data.repository.CrudRepository;
import work.rabbi.domain.Owner;

public interface OwnerRepository extends CrudRepository<Owner, Long> {
}
