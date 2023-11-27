package work.rabbi.rediscache.entity;


import jakarta.persistence.*;

import java.io.Serializable;

@Entity
public class Book implements Serializable {

    private static final long serialVersionUID = 7156526077883281623L;

    @Id
    @SequenceGenerator(name = "SEQ_GEN", sequenceName = "SEQ_Book", allocationSize = 1)
    @GeneratedValue(strategy = GenerationType.SEQUENCE, generator = "SEQ_GEN")
    private Long id;
    private String name;
    private long pages;

    public Book() {
    }

    public Book(String name, long pages) {
        this.name = name;
        this.pages = pages;
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public long getPages() {
        return pages;
    }

    public void setPages(long pages) {
        this.pages = pages;
    }

    @Override
    public String toString() {
        return String.format("Book{id=%d, name='%s', pages=%d}", id, name, pages);
    }
}
