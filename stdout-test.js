process.stdin.setEncoding("utf8");

process.stdin.on("readable", () => {
  let chunk;
  // Use a loop to make sure we read all available data.
  chunk = process.stdin.read();
  process.stdout.write(`data: ${chunk}`);
});
