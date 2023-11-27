package work.rabbi.rediscache.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import work.rabbi.rediscache.entity.Book;

@Repository
public interface BookRepository extends JpaRepository<Book, Long> {
}
