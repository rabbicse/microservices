package work.rabbi.auth_server.core;

import io.jsonwebtoken.*;
import io.jsonwebtoken.io.Decoders;
import io.jsonwebtoken.security.Keys;
import lombok.Getter;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.stereotype.Service;

import java.security.Key;
import java.util.Date;

@Service
public class JwtService {
    @Value("${security.jwt.secret-key}")
    private String secretKey;
    @Value("${security.jwt.expiration-time}")
    @Getter
    private long jwtExpirationInMilliseconds;

    public String generateToken(UserDetails userDetails){
        return Jwts.builder()
                .setSubject(userDetails.getUsername())
                .setIssuedAt(new Date(System.currentTimeMillis()))
                .setExpiration(new Date(System.currentTimeMillis() +  jwtExpirationInMilliseconds))
                .signWith(getSignInKey(), SignatureAlgorithm.HS256)
                .compact();
    }

    public boolean isTokenValid(String token, UserDetails userDetails){
        String username = extractUsername(token);
        return username.equals(userDetails.getUsername()) && !isTokenExpired(token);
    }

    private boolean isTokenExpired(String token){
        Date expirationDate = extractAllClaims(token).getExpiration();
        Date currentDate = new Date();
        return expirationDate.before(currentDate);
    }

    public String extractUsername(String token){
        return extractAllClaims(token).getSubject();
    }

    private Claims extractAllClaims(String token){
        JwtParser jwtParser = Jwts.parserBuilder()
                .setSigningKey(getSignInKey())
                .build();
        Jws<Claims> claimsJws = jwtParser.parseClaimsJws(token);
        return claimsJws.getBody();
    }

    private Key getSignInKey(){
        return Keys.hmacShaKeyFor(Decoders.BASE64.decode(secretKey));
    }
}
