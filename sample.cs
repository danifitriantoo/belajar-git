using(SqlConnection conn = new SqlConnection) {
  conn.Open();
  var query = "SELECT * FROM ADMIN";
  SqlCommand cmd = new SqlCommand(query, conn);
  cmd.ExecuteNonQuery;
}
