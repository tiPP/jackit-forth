\ Copyright (c) 2009 Marcus Eskilsson. All rights reserved.

\ Redistribution and use in source and binary forms, with or without
\ modification, are permitted provided that the following conditions
\ are met:
\ 1. Redistributions of source code must retain the above copyright
\    notice, this list of conditions and the following disclaimer.
\ 2. Redistributions in binary form must reproduce the above copyright
\    notice, this list of conditions and the following disclaimer in the
\    documentation and/or other materials provided with the distribution.

\ THIS SOFTWARE IS PROVIDED BY AUTHOR AND CONTRIBUTORS ``AS IS'' AND
\ ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
\ IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
\ ARE DISCLAIMED.  IN NO EVENT SHALL AUTHOR OR CONTRIBUTORS BE LIABLE
\ FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
\ DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS
\ OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
\ HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT
\ LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY
\ OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF
\ SUCH DAMAGE.

: null-terminate  ( u c-addr -- )
	+ 0 swap c!
;
: c-string
	create ( c-addr u -- ) 	dup 1+ allocate drop dup ,
							2dup null-terminate
							swap move
	does>  ( -- a ) @
;

s" 32 bit float mono audio" c-string jack-default-audio-type


0x00	constant	JackNullOption
0x01	constant	JackNoStartServer
0x02	constant	JackUseExactName
0x04	constant	JackServerName
0x08	constant	JackLoadName
0x10	constant	JackLoadInit

0x01	constant	JackPortIsInput
0x02	constant	JackPortIsOutput
0x04	constant	JackPortIsPhysical
0x08	constant	JackPortCanMonitor
0x10	constant	JackPortIsTerminal

