#include <stddef.h>
struct Node {
	struct Node *next;
	int data;
};

int index_of (const struct Node *list, int search_val)
{
  if(list == NULL) {
    return -1;
  }
  struct Node node = *list;
  if(node.data == search_val) {
    return 0;
  }
  int idx = 0;
  while(node.next != NULL) {
    idx++;
    node = *node.next;
    if(node.data == search_val) {
      return idx;
    }
  }
	return -1;
}