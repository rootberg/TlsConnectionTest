# Test TLS Connection

I was searching for a simple program to test the connection between the executing client and a website using the windows/.net settings, and could find none. So I searched all over on how to inspect the crypto information with the .net Framework, and found a few different aticles (I wish I remember where I found them so I could include them here) and the MSDN doc on the "SslStream" (System.Net.Security.SslStream). I put it all together and created this little app.

Note that different applications on windows may not use the Windows SCHANNEL settings, and may be using another library, so this test would not apply.

If you want to see how applications are comunicating, you are better off using somthing like Wireshark, but that is overkill for what I was trying to acomplish.
