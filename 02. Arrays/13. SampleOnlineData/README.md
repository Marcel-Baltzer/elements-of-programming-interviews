## 13. Sample online data

This problem is motivated by the design of a packet sniffer that provides a uniform sample of packets for a network session.

Design a program that takes as input a size k, and reads packets, continuously maintaining a uniform random subset of size k of the read packets.

>Hint: Suppose you have a procedure which selects k packets from the first n > k packets as specified. How would you deal with the (n + 1)th packet?
