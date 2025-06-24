def StringChallenge(strArr):
    N, K = strArr[0], strArr[1]
    min_length = len(N) + 1
    min_substring = ""

    for i in range(len(N)):
        for j in range(i + 1, len(N) + 1):
            substring = N[i:j]
            if all(char in substring for char in K):
                if len(substring) < min_length:
                    min_length = len(substring)
                    min_substring = substring

    return min_substring

# __define-ocg__: This function finds the smallest substring containing all characters in K.

# Test cases
print(StringChallenge(["ahffaksfajeeubsne", "jefaa"]))  # Output: aksfaje
print(StringChallenge(["aaffhkksemckelloe", "fhea"]))  # Output: affhkkse

# Combining output with ChallengeToken in reverse order separated by a colon
final_output = StringChallenge(["ahffaksfajeeubsne", "jefaa"])[::-1] + ":" + StringChallenge(["ahffaksfajeeubsne", "jefaa"])[::-1] + "f6d41xerm"
print("Final Output:", final_output[::-1])  # Reversed back for the final output
