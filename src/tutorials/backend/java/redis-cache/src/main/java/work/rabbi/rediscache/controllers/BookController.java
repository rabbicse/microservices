package work.rabbi.rediscache.controllers;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.cache.annotation.CacheEvict;
import org.springframework.cache.annotation.CachePut;
import org.springframework.cache.annotation.Cacheable;
import org.springframework.web.bind.annotation.*;
import work.rabbi.rediscache.entity.Book;
import work.rabbi.rediscache.repositories.BookRepository;


import java.util.Optional;

@RestController
public class BookController {

    private final Logger LOG = LoggerFactory.getLogger(getClass());

    private final BookRepository bookRepository;

    @Autowired
    public BookController(BookRepository bookRepository) {
        this.bookRepository = bookRepository;
    }

    @Cacheable(value = "books", key = "#bookId", unless = "#result.pages < 300")
    @RequestMapping(value = "/get/{bookId}", method = RequestMethod.GET)
    public Book getBook(@PathVariable String bookId) {
        LOG.info("Getting book with ID {}.", bookId);
        long i = Long.valueOf(bookId);
        return bookRepository.findById(i).orElse(null);
    }

    @CachePut(value = "books", key = "#book.id")
    @PutMapping("/add")
    public Book addBook(@RequestBody Book book) {
        bookRepository.save(book);
        return book;
    }

    @CacheEvict(value = "books", allEntries = true)
    @DeleteMapping("/delete/{bookId}")
    public void deleteUserByID(@PathVariable Long bookId) {
        LOG.info("deleting Book with id {}", bookId);
        Optional<Book> bk = bookRepository.findById(bookId);
        if (!bk.isEmpty()) {
            Book book = bk.get();
            bookRepository.delete(book);

        }
    }
}